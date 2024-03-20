namespace Classes.Exceptions
{
    public class InvalidNumeroException : Exception
    {
        public InvalidNumeroException(string message): base(message){
        }

        public override string Message
        {
            get
            {
                return "La longueur du numero doit être comprit entre 4 et 6 chiffres";
            }
        }
    }
}
