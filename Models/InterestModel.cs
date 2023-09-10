namespace TinhLaiSuatWeb.Models
{
    public class InterestModel
    {
        public double Money { get; set; }
        public double InterestRate { get; set; }
        public double Time { get; set; }
        public double Total { get; set; }
        public double Interest { get; set; }
        public double InterestConvert { get; set; }

        public InterestModel() { }

        public InterestModel(int moneyInput, int interestInput, int timeInput)
        {
            this.Money = moneyInput;
            this.InterestRate = interestInput;
            this.Time = timeInput;
            this.InterestConvert = InterestRate/100;
            this.Interest = Money * InterestConvert/12 * Time;
            this.Total = Interest + Money;
            
        }
    }
}
