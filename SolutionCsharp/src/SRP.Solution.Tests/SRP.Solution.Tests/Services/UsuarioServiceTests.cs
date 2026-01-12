using Moq;
using SRP.Solution.Interfaces;

namespace SRP.Solution.Tests.Services
{
    public class UsuarioServiceTests
    {
        [Fact]
        public void CriarUsuario_DadosValidos_DeveExecutarFluxoCompleto()
        {
            // Arrange
            // Crie um objeto falso que finge ser um IUsuarioValidator
            var validatorMock = new Mock<IUsuarioValidator>();
            var repositoryMock = new Mock<IUsuarioRepository>();
            var emailServiceMock = new Mock<IEmailService>();

            var service = new UsuarioService(
                validatorMock.Object,
                repositoryMock.Object,
                emailServiceMock.Object
            );

            var nome = "Wesley";
            var email = "wesley@email.com";

            // Act
            service.CriarUsuario(nome, email);

            // Assert
            // Verifique se esse método foi chamado
            validatorMock.Verify(
                // O método deve ter sido chamado com um Usuario cujo nome e email sejam exatamente esses
                v => v.Validar(It.Is<Usuario>(u =>
                    u.Nome == nome &&
                    u.Email == email
                )),
                Times.Once
            );

            repositoryMock.Verify(
                r => r.Salvar(It.Is<Usuario>(u =>
                    u.Nome == nome &&
                    u.Email == email
                )),
                Times.Once
            );

            emailServiceMock.Verify(
                e => e.Enviar(email),
                Times.Once
            );
        }

        [Fact]
        public void CriarUsuario_DadosInvalidos_DeveLancarExcecaoENaoExecutarFluxo()
        {
            // Arrange
            var validatorMock = new Mock<IUsuarioValidator>();
            var repositoryMock = new Mock<IUsuarioRepository>();
            var emailServiceMock = new Mock<IEmailService>();

            // Força o validator a falhar
            validatorMock
                .Setup(v => v.Validar(It.IsAny<Usuario>()))
                .Throws(new ArgumentException("Email inválido"));

            var service = new UsuarioService(
                validatorMock.Object,
                repositoryMock.Object,
                emailServiceMock.Object
            );

            // Act
            var act = () => service.CriarUsuario("Wesley", "email-invalido");

            // Assert
            Assert.Throws<ArgumentException>(act);

            repositoryMock.Verify(
                r => r.Salvar(It.IsAny<Usuario>()),
                Times.Never
            );

            emailServiceMock.Verify(
                e => e.Enviar(It.IsAny<string>()),
                Times.Never
            );
        }

    }
}
