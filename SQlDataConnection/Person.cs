namespace MyCalc
{
    public class Person
    {
        //stuff we want to get from database
        public int actor_id { get; set; }

        public string first_name { get; set; }
        public string last_name { get; set; }

        //get FullInfo to be displayed
        public string FullInfo
        {
            get
            {
                return $"{ first_name } { last_name } ({actor_id})";
            }
        }
    }
}