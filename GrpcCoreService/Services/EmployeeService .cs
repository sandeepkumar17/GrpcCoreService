using Grpc.Core;
using GrpcCoreService.EmployeeProtos;

namespace GrpcCoreService.Services
{
    public class EmployeeService : Employee.EmployeeBase
    {
        private readonly ILogger<EmployeeService> _logger;
        public EmployeeService(ILogger<EmployeeService> logger)
        {
            _logger = logger;
        }

        public override Task<EmpModel> GetEmpInformation(GetEmpDetail request, ServerCallContext context)
        {
            var employee = new EmpModel();

            switch (request.EmpId)
            {
                case 1:
                   return Task.FromResult(new EmpModel
                    {
                        EmpName = "Sandeep Kumar",
                        EmpEmail = "sk@testorg.com",
                        EmpDepartment = "Information Technology",
                        EmpRole = "Technical Leader"
                    });
                case 2:
                    return Task.FromResult(new EmpModel
                    {
                        EmpName = "Test Emp2",
                        EmpEmail = "testemp2@testorg.com",
                        EmpDepartment = "Finance",
                        EmpRole = "Manager"
                    });
                case 3:
                    return Task.FromResult(new EmpModel
                    {
                        EmpName = "Test Emp3",
                        EmpEmail = "testemp3@testorg.com",
                        EmpDepartment = "HR",
                        EmpRole = "Associate"
                    });
                case 4:
                    return Task.FromResult(new EmpModel
                    {
                        EmpName = "Test Emp4",
                        EmpEmail = "testemp4@testorg.com",
                        EmpDepartment = "Operation",
                        EmpRole = "Analyst"
                    });
                case 5:
                    return Task.FromResult(new EmpModel
                    {
                        EmpName = "Test Emp5",
                        EmpEmail = "testemp5@testorg.com",
                        EmpDepartment = "Executive",
                        EmpRole = "Director"
                    });
                default:
                    return Task.FromResult(employee);
            }
        }
    }
}