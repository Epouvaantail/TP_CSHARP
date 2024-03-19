namespace Classes.Exceptions
{
    public class InvalidNumeroException : Exception
    {
        public InvalidNumeroException(string message)
            : base(message)
        {
        }
        public InvalidNumeroException()
            : base()
        {
        }

        public override string Message      //Redéfinition de la propriété Message
        {
            get
            {
                return "Le numero doit être comprit entre 4 et 6 chiffres";
            }
        }
    }
}
