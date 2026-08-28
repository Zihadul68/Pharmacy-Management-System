using System;

namespace PharmacyManagement
{
    /// <summary>Contains billing rules that can be exercised independently of the WinForms UI.</summary>
    public static class BillingCalculator
    {
        public static int CalculateLineTotal(int quantity, int unitPrice)
        {
            if (quantity <= 0 || unitPrice <= 0)
            {
                return 0;
            }

            checked
            {
                return quantity * unitPrice;
            }
        }

        public static bool CanFulfil(int requestedQuantity, int availableQuantity)
        {
            return requestedQuantity > 0 && availableQuantity >= requestedQuantity;
        }
    }
}
