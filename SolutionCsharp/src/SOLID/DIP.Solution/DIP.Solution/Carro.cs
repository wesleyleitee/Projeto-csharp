namespace DIP.Solution
{
    internal class Carro
    {
        private readonly IMotor _motor;

        //Depende da abstração
        public Carro(IMotor motor)
        {
            _motor = motor;
        }

        public void Andar()
        {
            _motor.Ligar();
            Console.WriteLine("Carro andando");
        }
    }
}
