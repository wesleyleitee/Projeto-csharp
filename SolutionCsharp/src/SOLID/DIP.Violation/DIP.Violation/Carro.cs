namespace DIP.Violation
{
    // Alto nível (regra de negócio)
    internal class Carro
    {
        private readonly MotorCombustao _motor;

        public Carro()
        {
            // DIP VIOLATION, carro está conhecendo o tipo exato do motor
            _motor = new MotorCombustao(); 
        }

        public void Andar()
        {
            _motor.Ligar();
            Console.WriteLine("Carro andando");
        }
    }
}
