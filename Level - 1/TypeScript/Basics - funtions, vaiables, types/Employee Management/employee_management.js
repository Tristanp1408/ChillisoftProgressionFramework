var BaseEmployee = /** @class */ (function () {
    function BaseEmployee(id, name, salary) {
        this.id = id;
        this.name = name;
        this.salary = salary;
    }
    BaseEmployee.prototype.getDetails = function () {
        return "\uD83D\uDC68\u200D\uD83D\uDCBC ".concat(this.name, " - Salary: $").concat(this.salary);
    };
    return BaseEmployee;
}());
var employees = [];
var employeeNameInput = document.getElementById("employeeName");
var employeeSalaryInput = document.getElementById("employeeSalary");
var employeeList = document.getElementById("employeeList");
var addEmployeeBtn = document.getElementById("addEmployeeBtn");
if (!addEmployeeBtn) {
    console.error("❌ ERROR: Add Employee button not found!");
}
else {
    addEmployeeBtn.addEventListener("click", addEmployee);
}
function addEmployee() {
    var name = employeeNameInput.value.trim();
    var salary = parseFloat(employeeSalaryInput.value);
    if (!name || isNaN(salary) || salary <= 0) {
        console.log("❌ Invalid Name or Salary!");
        return;
    }
    var newEmployee = new BaseEmployee(Date.now(), name, salary);
    employees.push(newEmployee);
    updateEmployeeUI();
}
function updateEmployeeUI() {
    employeeList.innerHTML = "";
    employees.forEach(function (employee) {
        var li = document.createElement("li");
        li.textContent = employee.getDetails();
        employeeList.appendChild(li);
    });
}
