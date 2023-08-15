using CrudApp.Models;

namespace CrudApp.Services
{
    public class TodoService
    {
        // Get Data
        public List<Todo> AllTask()
        {

            var datas = new List<Todo>();

            var data1 = new Todo
            {
                Id = 1,
                Name = "Janaka",
                Description = "Hello janaka",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now.AddDays(5),
                Status = TodoStatus.New
            };
            datas.Add(data1);
            var data2 = new Todo
            {
                Id = 2,
                Name = "Kasun",
                Description = "Hello Kasun",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now.AddDays(5),
                Status = TodoStatus.Inprogress
            };
            datas.Add(data2);
            var data3 = new Todo
            {
                Id = 3,
                Name = "keshan",
                Description = "Hello keshan",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now.AddDays(5),
                Status = TodoStatus.End
            };
            datas.Add(data3);

            return datas;
        }
    }
}
