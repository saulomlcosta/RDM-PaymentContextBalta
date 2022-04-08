using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document : ValueObject
    {
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;

            if (string.IsNullOrEmpty(Number))
                AddNotification("Number", "Invalid number");
        }

        public string Number { get; private set; }
        public EDocumentType Type { get; private set; }
    }
}