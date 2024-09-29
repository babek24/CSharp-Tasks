

using MiniProject.Models;

namespace MiniProject.Services
{
    internal class GroupService
    {
        // Groupa elave, Grouplarin cixarilmasi kimi serviceler
        private readonly List<Group> _groups=new List<Group>();
        public void AddGroup()
        {
            Console.Write("Enter Group Name: ");

            string name=Console.ReadLine();

            Group group = new Group()
            {
                Name = name,

                Id = Guid.NewGuid(),

                CreatedDate = DateTime.Now,

            };
            _groups.Add(group);
        }

        public void EditGroup()
        {
            Console.WriteLine("Enter group Id: ");
            string Id = Console.ReadLine();

            foreach (var group in _groups)

            {
                if (group.Id == Guid.Parse(Id))
                {
                    Console.WriteLine("Enter new group name: ");
                    string name = Console.ReadLine();
                    group.Name = name;
                    group.ModifiedDate = DateTime.Now;
                    Console.WriteLine("Success");
                    return;
                }
            }
            Console.WriteLine("Group not found");
        }
        public void DeleteGroup()
        {
            Console.WriteLine("Enter group Id: ");
            string id = Console.ReadLine();
            foreach (var group in _groups)

            {
                if (group.Id == Guid.Parse(id))
            }
        }
        
    }
}
