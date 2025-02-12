interface Employee {
  id: number;
  name: string;
  salary: number;
  getDetails(): string;
}

class BaseEmployee implements Employee {
  constructor(public id: number, public name: string, public salary: number) {}

  getDetails(): string {
    return `👨‍💼 ${this.name} - Salary: $${this.salary}`;
  }
}

let employees: Employee[] = [];

const employeeNameInput = document.getElementById(
  "employeeName"
) as HTMLInputElement;

const employeeSalaryInput = document.getElementById(
  "employeeSalary"
) as HTMLInputElement;

const employeeList = document.getElementById(
  "employeeList"
) as HTMLUListElement;

const addEmployeeBtn = document.getElementById("addEmployeeBtn");

if (!addEmployeeBtn) {
  console.error("❌ ERROR: Add Employee button not found!");
} else {
  addEmployeeBtn.addEventListener("click", addEmployee);
}

function addEmployee(): void {
  const name = employeeNameInput.value.trim();
  const salary = parseFloat(employeeSalaryInput.value);

  if (!name || isNaN(salary) || salary <= 0) {
    console.log("❌ Invalid Name or Salary!");
    return;
  }

  const newEmployee = new BaseEmployee(Date.now(), name, salary);
  employees.push(newEmployee);

  updateEmployeeUI();
}

function updateEmployeeUI(): void {
  employeeList.innerHTML = "";

  employees.forEach((employee) => {
    const li = document.createElement("li");
    li.textContent = employee.getDetails();
    employeeList.appendChild(li);
  });
}
