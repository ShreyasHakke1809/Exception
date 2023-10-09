namespace ExceptionProblem
{
    public class PersonAge
    {
        public int age;
        public PersonAge(int agee)
        {
            this.age = agee;
        }
        public int Category()
        {
            try
            {
                if (this.age.Equals(0))
                {
                    throw new CustomException(CustomException.ExceptionTypes.NULL_EXCEPTION, "Age should not be null");
                }
                else if (this.age.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionTypes.EMPTY_EXCEPTION, "Age should not be empty");
                }
                else if (this.age >= 1 && this.age <= 14)
                {
                    Console.WriteLine("Children");
                    return this.age;
                }
                else if (this.age >= 15 && this.age <= 24)
                {
                    Console.WriteLine("Youth");
                    return this.age;
                }
                else if (this.age >= 25 && this.age <= 64)
                {
                    Console.WriteLine("Adults");
                    return this.age;
                }
                else if (this.age >= 65)
                {
                    Console.WriteLine("Seniors");
                    return this.age;
                }
                else if (this.age < 0)
                {
                    Console.WriteLine("Age should not be negative");
                    return this.age;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
