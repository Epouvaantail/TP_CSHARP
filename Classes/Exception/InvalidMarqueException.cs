namespace Classes.Exceptions
{
    public class InvalidMarqueException : Exception
    {
        public InvalidMarqueException(string message): base(message){
        }

        public override string Message
        {
            get
            {
                return "Le Marque ne doit pas comprendre chiffres";
            }
        }
    }
}
