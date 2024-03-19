namespace Classes.Exceptions
{
    public class InvalidMarqueException : Exception
    {
        public InvalidMarqueException(string message)
            : base(message)
        {
        }
        public InvalidMarqueException()
            : base()
        {
        }

        public override string Message      //Redéfinition de la propriété Message
        {
            get
            {
                return "Le Marque ne doit pas comprendre chiffres";
            }
        }
    }
}
