using System.Collections;

namespace HomeTask_3_1.Task3
{
    public class Week : IEnumerable
    {
        private string[] _days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(_days);
        }
    }
}
