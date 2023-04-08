namespace GenericClassess.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; } = String.Empty;

        public abstract void GetInfo();


    }
}
