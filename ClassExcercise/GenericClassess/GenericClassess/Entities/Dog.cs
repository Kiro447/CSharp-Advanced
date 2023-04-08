namespace GenericClassess.Entities
{
    public class Dog : BaseEntity
    {
        public bool IsShepard { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"Dog info:\n Name:{Name}\n Is the dog a shepard: {(IsShepard ? "yes" : "no")}");
        }
    }
}
