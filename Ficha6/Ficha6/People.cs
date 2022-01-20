namespace Ficha6
{
    public class People
    {
        public List<Person> PersonList { get; set;}
        public void Add(Person person)
        {
            PersonList.Add(person);
        }

    }

}
