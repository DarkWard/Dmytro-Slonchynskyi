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
    name: 'Employee 1', employees: [
      { name: 'Employee 4', employees: [] },
      { name: 'Employee 5', employees: [] },
      { name: 'Employee 6', employees: [] },
    ]
  },

  {
    name: 'Employee 2', employees: [
      { name: 'Employee 7', employees: [] },
      { name: 'Employee 8', employees: [] },
      { name: 'Employee 9', employees: [] },
    ]
  },

  {
    name: 'Employee 3', employees: [
      { name: 'Employee 10', employees: [] },
      { name: 'Employee 11', employees: [] },
      { name: 'Employee 12', employees: [] },
    ]
  },
];

class Manager extends React.Component {
  constructor(props) {
    super(props);
    this.unemploy = this.unemploy.bind(this);
    this.showPerson = this.showPerson.bind(this);

    this.state = {
      name: this.props.name,
      person: null,
      manager: null,
      data: [...this.props.data],
      main: [...this.props.data],
    };
  }

  unemploy(input) {
    if (input.manager != null) {
      let tmp = [...input.manager.data];
      for (let i = 0; i < tmp.length; i++) {
        if (tmp[i] == input) {
          let emp = [...tmp[i].employees];

          for (let k = 0; k < emp.length; k++) {
            emp[k].manager = input.manager;
            tmp.push(emp[k])
          }

          tmp.splice(i, 1);
          break;
        }
        else {
          for (let j = 0; j < tmp[i].employees.length; j++) {
            if (tmp[i].employees[j] == input) {
              tmp[i].employees.splice(j, 1);
              break;
            }
          }
        }
      }
      input.manager.data = tmp;

      alert("You've been unemployed!");
      this.showPerson(this.state.manager, -1);
    }
    else if (this.state.manager == null) {
      alert("You can't unemploy boss manager!")
    }
  }

  showPerson(person, move) {
    if (move == -1) {
      if (this.state.manager == null) {
        alert("It's boss manager! No higher manager!")
      }
      else {
        this.setState({
          name: person.name,
          person: person,
          data: person.data,
          manager: person.manager,
        });
      }
    }
    else if (move == 1) {
      let manager = { name: this.state.name, manager: this.state.manager, data: this.state.data }
      person.manager = manager;

      this.setState({
        name: person.name,
        person: person,
        manager: manager,
        data: person.employees
      });
    }
  }

  render() {
    return <>
      <table>
        <tr>
          <td>{this.state.name}<button onClick={() => this.showPerson(this.state.manager, -1)}>Manager</button></td>
          <td><button onClick={() => this.unemploy(this.state.person)}>Unemploy</button></td>
        </tr>
        <tr>
          {this.state.data.map((emp) => {
            return (
              <td><button onClick={() => this.showPerson(emp, 1)}>{emp.name}</button></td>
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