namespace Lecture
{
    public partial class LectureExample
    {
        /*
        15. Now, do it again with a different bool operation.
        TOPIC: Logical Not
        */
        public string ReturnAdultOrMinorAgain(int number)
        {
            if (number !< 17)
            {
                return "adult";
            }
            else
            {
                return "minor";
            }
        }
    }
}
