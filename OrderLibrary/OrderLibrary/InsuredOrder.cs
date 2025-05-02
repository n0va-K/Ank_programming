namespace OrderLibrary
{
    public class InsuredOrder : Order
    {
        public string InsuarenceCompany { get; set; }
        public int InsuarenceAmount { get; set; }

        public InsuredOrder(string itemName, string itemID, string courierSurname, string orderNumber,
                             string company, int amount)
            : base(itemName, itemID, courierSurname, orderNumber)
        {
            InsuarenceCompany = company;
            InsuarenceAmount = amount;
        }

        public override string[] GetInfo()
        {
            var info = base.GetInfo();
            info[1] += $"\nНазвание страховой компании: {InsuarenceCompany}" +
                        $"\nСумма страховки: {InsuarenceAmount} руб.";

            return info;
        }

    }
}
