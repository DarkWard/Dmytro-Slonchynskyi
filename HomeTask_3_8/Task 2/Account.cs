using System;
namespace HomeTask_3_8
{
    public class Account
    {
        private float _balance;

        public event EventHandler EIncome;
        public event EventHandler EOutcome;

        public string Name { get; set; }
        public float Balance { get => _balance; }

        public void Income(EventArgs e)
        {
            var eve = EIncome;
            EIncome?.Invoke(this, e);
        }

        public void Outcome(EventArgs e)
        {
            var eve = EOutcome;
            EOutcome?.Invoke(this, e);
        }
    }
}
