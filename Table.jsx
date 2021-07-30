class Application extends React.Component {
  render() {
    return <>
      <Manager name="Manager" data={employees} />
      <br />
    </>;
  }
}

let employees = [
  {
    name: 'Employee 1', manager: '0', employees: [
      { name: 'Employee 4', manager: '1', employees: [] },
      { name: 'Employee 5', manager: '1', employees: [] },
      { name: 'Employee 6', manager: '1', employees: [] },
    ]
  },

  {
    name: 'Employee 2', manager: '0', employees: [
      { name: 'Employee 7', manager: '2', employees: [] },
      { name: 'Employee 8', manager: '2', employees: [] },
      { name: 'Employee 9', manager: '2', employees: [] },
    ]
  },

  {
    name: 'Employee 3', manager: '0', employees: [
      { name: 'Employee 10', manager: '3', employees: [] },
      { name: 'Employee 11', manager: '3', employees: [] },
      { name: 'Employee 12', manager: '3', employees: [] },
    ]
  },
];

class Manager extends React.Component {
  constructor(props) {
    super(props);
    this.unemploy = this.unemploy.bind(this);
    this.showManager = this.showManager.bind(this);
    this.showEmployee = this.showEmployee.bind(this);

    this.state = {
      name: this.props.name,
      data: [...this.props.data],
      main: [...this.props.data],
      manager: this.props.manager,
    };
  }

  unemploy(input) {
    if (input === "Manager") {
      alert("You can't unemploy boss manager!")
    }
    else {
      let tmp = [...this.state.main];

      for (let i = 0; i < tmp.length; i++) {
        if (tmp[i].name == input) {
          let emp = [...tmp[i].employees];

          for (let k = 0; k < emp.length; k++) {
            emp[k].manager = '0';
            tmp.push(emp[k])
          }

          tmp.splice(i, 1);
          break;
        }
        else {
          for (let j = 0; j < tmp[i].employees.length; j++) {
            if (tmp[i].employees[j].name == input) {
              tmp[i].employees.splice(j, 1);
              break;
            }
          }
        }
      }

      this.setState({
        main: tmp
      });
      alert("You've been unemployed!");

      this.showManager(0);
    }
  }

  showManager(manager) {
    if (this.state.name == "Manager") {
      alert("It's boss manager! No higher manager!")
    }
    else if (manager == 0) {
      this.setState({
        name: "Manager",
        data: this.state.main
      });
      alert("Here's manager")
    }
    else {
      let e = this.state.main[manager - 1];

      this.setState({
        name: e.name,
        manager: e.manager,
        data: e.employees
      });

      alert("Here's manager")
    }
  }

  showEmployee(input) {
    let e = this.state.data.filter(e => e.name == input)[0];
    this.setState({
      name: e.name,
      manager: e.manager,
      data: e.employees
    });

    alert("Here's employee")
  }

  render() {
    return <>
      <table>
        <tr>
          <td>{this.state.name}<button onClick={() => this.showManager(this.state.manager)}>Manager</button></td>
          <td><button onClick={() => this.unemploy(this.state.name)}>Unemploy</button></td>
        </tr>
        <tr>
          {this.state.data.map((emp) => {
            return (
              <td><button onClick={() => this.showEmployee(emp.name)}>{emp.name}</button></td>
            )
          })
          }
        </tr>
      </table>
    </>;
  }
}

ReactDOM.render(
  <Application />,
  document.getElementById("app")
)