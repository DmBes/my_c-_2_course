namespace laba3.Properties
{
    public class motors
    {
        
        public string Motor_name = "None";
        public string gas = "None";

        public motors(string Name, string gasoline)
        {
            Motor_name = Name;
            gas = gasoline;
        }


        public motors()
        {
        }

        public motors(string Name) : this(Name, "Do not gasoline")
        {
            
        }

    }
}