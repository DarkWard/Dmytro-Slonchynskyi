class Application extends React.Component {
  render() {
    return <>
      <Table columns={3} rows={3} data={startData} /><br />
    </>;
  }
}

let startData = [
  [1, 2, 3],
  [4, 5, 6],
  [7, 8, 9]
];

class Table extends React.Component {

  constructor(props) {
    super(props);

    this.state = {
      rows: this.props.rows,
      columns: this.props.columns,
      data: [...this.props.data]
    }

    this.onAddColumn = this.onAddColumn.bind(this);
    this.onAddRow = this.onAddRow.bind(this);
  }

  onAddColumn(index) {
    let tempData = [...this.state.data]
    for (let j = 0; j < tempData.length; j++) {
      tempData[j].push(0);
      for (let i = tempData[j].length - 1; i > index; i--) {
        let temp = tempData[j][i];
        tempData[j][i] = tempData[j][i - 1];
        tempData[j][i - 1] = temp;
      }
    }

    this.setState({ data: tempData });
  }

  onAddRow(index) {

    let tempData = [...this.state.data]
    let add = [];
    for (let i = 0; i < tempData[0].length; i++){
      add.push(0);
    }
    tempData.push(add);
    for(let i = tempData.length - 1; i > index; i--){
      let tmp = tempData[i];
      tempData[i] = tempData[i - 1];
      tempData[i - 1] = tmp;
    }  

    this.setState({ data: tempData });
  }

  render() {
    return <>
      <table>
        <HeaderRow data={this.state.data} onAdd={this.onAddColumn} />
        <TableBody data={this.state.data} onAdd={this.onAddRow} />
      </table>
    </>;
  }
}

class HeaderRow extends React.Component {
  constructor(props) {
    super(props);

    this.onAddColumn = this.onAddColumn.bind(this);

    this.state = { data: this.props.data }
  }

  onAddColumn(i) {
    this.props.onAdd(i);
  }

  render() {
    let array = [];
    for (var i = 0; i < this.state.data[0].length; i++)
      array.push(i);

    return array.map(i => <td><button onClick={() => this.onAddColumn(i)}>+</button></td>)
  }
}

class SideRow extends React.Component {
  constructor(props) {
    super(props);

    this.addRow = this.addRow.bind(this);

    this.state = { index: this.props.index }
  }

  addRow(index) {
    this.props.onAdd(index);
  }

  render() {
    return <button onClick={() => this.addRow(this.props.index)}>+</button>
  }
}

class TableBody extends React.Component {

  constructor(props) {
    super(props);
  }

  render() {
    let rows = [];
    for (let i = 0; i < this.props.data.length; i++) {
      rows.push(<tr><SideRow index={i} onAdd={this.props.onAdd} />{this.props.data[i].map(k => <td><input type="text" value={k} /></td>)}</tr>);
    }
    return rows;
  }

}

ReactDOM.render(
  <Application />,
  document.getElementById("app")
)