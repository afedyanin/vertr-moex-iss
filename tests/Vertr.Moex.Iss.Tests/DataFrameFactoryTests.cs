using System.Text.Json;
using Microsoft.Data.Analysis;
using Vertr.Moex.Iss.Entities;

namespace Vertr.Moex.Iss.Tests;

[TestFixture(Category = "Integration")]
public class DataFrameFactoryTests
{
    [Test]
    public async Task CanCreateDataFrameForBondSecurities()
    {
        var url = new UrlBuilder()
            .Engines(Engine.Stock)
            .Markets(Market.Stock_Bonds)
            .Securities()
            .IncludeMeta(false)
            .OnlyBlocks([BlockNames.Securities])
            .Build();

        using var http = new HttpClient();

        var json = await http.GetStringAsync(url, CancellationToken.None);
        Assert.That(json, Is.Not.Empty);

        var jDoc = JsonDocument.Parse(json);
        var node = jDoc.RootElement.GetProperty("securities");
        var columns = node.GetProperty("columns").Deserialize<string[]>();
        var rows = node.GetProperty("data").EnumerateArray();
    }

    [Test]
    public void CanCreateSimpleDataFrame()
    {
        string[] names = ["John", "Ahmed", "Chris", "Albert"];
        int[] salaries = [20000, 30000, 40000, 10000];
        string?[] departments = ["Development", "Development", "HR", null];

        DateTime[] birthdays = [
            DateTime.Parse("23/4/1990"),
            DateTime.Parse("4/5/1982"),
            DateTime.Parse("2/1/1980"),
            DateTime.Parse("9/10/1994")];

        int[] ids1 = [1, 2, 3, 4];
        var idColumn1 = new PrimitiveDataFrameColumn<int>("Id", ids1);
        var nameColumn = new StringDataFrameColumn("Name", names);
        var birthdayColumn = new PrimitiveDataFrameColumn<DateTime>("Birthday", birthdays);
        var salaryColumn = new PrimitiveDataFrameColumn<int>("Salary", salaries);

        int[] ids2 = [3, 1, 2, 4];
        var idColumn2 = new PrimitiveDataFrameColumn<int>("EmployeeId", ids2);
        var departmentColumn = new StringDataFrameColumn("Department", departments);

        var employeesDf = new DataFrame(idColumn1, nameColumn, salaryColumn, birthdayColumn);
        var departmentsDf = new DataFrame(idColumn2, departmentColumn);


        Console.WriteLine(employeesDf);
        Console.WriteLine("=============");
        Console.WriteLine(departmentsDf);

        Assert.Pass();
    }
}
