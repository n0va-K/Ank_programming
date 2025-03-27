namespace OrderLibrary
{
    public class UrgentOrder : Order
    {
        public double UrgencyCoefficient { get; set; }
        public UrgencyType UrgencyLevel { get; set; }

        public UrgentOrder(string itemName, string itemID, string courierSurname, string orderNumber,
                          double coefficient, UrgencyType urgencyLevel)
            : base(itemName, itemID, courierSurname, orderNumber)
        {
            UrgencyCoefficient = coefficient;
            UrgencyLevel = urgencyLevel;
            Type = OrderType.Urgent;
        }

        public override string[] GetInfo()
        {
            var info = base.GetInfo();

            string urgency;
            if (UrgencyLevel == UrgencyType.WithinHour) urgency = "в течение часа";
            else if (UrgencyLevel == UrgencyType.WithinThreeHours) urgency = "в течение трех часов";
            else if (UrgencyLevel == UrgencyType.WithinDay) urgency = "в течение суток";
            else urgency = "не указано";

            info[1] += $"\nКоэффициент надбавки за срочность: {UrgencyCoefficient}" +
                          $"\nСтепень срочности: {urgency}";

            return info;
        }
        public enum UrgencyType
        {
            WithinHour,
            WithinThreeHours,
            WithinDay
        }
    }
}
