namespace ExceptionProblem
{
    public class CustomException : Exception
    {
        public ExceptionTypes type;
        public enum ExceptionTypes
        {
            NULL_EXCEPTION,
            EMPTY_EXCEPTION
        }
        public CustomException(ExceptionTypes type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
