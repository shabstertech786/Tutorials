using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppCore.Models;

namespace WebAppCore.Repositories
{
    public interface IHomeRepository
    {
        IEnumerable<HomeModel> GetHomeModels();
        HomeModel GetStudent(int id);

    }
    public class HomeRepository : IHomeRepository
    {
        private readonly ILogger<IHomeRepository> logger;
        public HomeRepository(ILogger<IHomeRepository> logger)
        {
            this.logger = logger;
        }

        public IEnumerable<HomeModel> GetHomeModels()
        {
            this.logger.BeginScope("GetHomeModel - Start");
            return new List<HomeModel>()
            {
                new HomeModel{StudentName="Amjad", RollNo = "WS13", Semester = "1st"},
                new HomeModel{StudentName="Aslam", RollNo = "WS11", Semester = "2nd"},
                new HomeModel{StudentName="Arif", RollNo = "WS12", Semester = "3rd"},
                new HomeModel{StudentName="Jamshed", RollNo = "WS14", Semester = "4th"},
            };
           
        }

        public HomeModel GetStudent(int id)
        {
            return new HomeModel { StudentName = "Amjad", RollNo = "WS13", Semester = "1st" };
        }
    }
}
