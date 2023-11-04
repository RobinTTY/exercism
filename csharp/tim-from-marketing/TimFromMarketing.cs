using System;
using System.Text;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        var departmentName  = (department ?? "OWNER").ToUpper();
        return (id != null) ? $"[{id}] - {name} - {departmentName}" : $"{name} - {departmentName}";
    }
}
