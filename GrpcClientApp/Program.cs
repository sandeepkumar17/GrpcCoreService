using Grpc.Net.Client;
using GrpcClientApp;

//var message = new HelloRequest
//{
//    Name = "Sandeep Kumar"
//};
//var channel = GrpcChannel.ForAddress("http://localhost:5181");
//var client = new Greeter.GreeterClient(channel);
//var serverReply = await client.SayHelloAsync(message);

//Console.WriteLine(serverReply.Message);
//Console.WriteLine("Press any key to exit...");
//Console.ReadKey();

var channel = GrpcChannel.ForAddress("http://localhost:5181");
var client = new Employee.EmployeeClient(channel);

Console.WriteLine("Enter Employee ID....");
var inputStr = Console.ReadLine();

int empId = 0;
if (!int.TryParse(inputStr, out empId))
{
    Console.WriteLine("This is invalid Employee ID, please exit and try again....");
}
else
{
    var emp = new GetEmpDetail { EmpId = empId };

    var serverReply = await client.GetEmpInformationAsync(emp);
    Console.WriteLine("Employee Name | Role | Email ID | Department");
    Console.WriteLine($"{serverReply.EmpName} | {serverReply.EmpRole} | {serverReply.EmpEmail} | {serverReply.EmpDepartment}");
}
Console.WriteLine("Press any key to exit...");
Console.ReadKey();


