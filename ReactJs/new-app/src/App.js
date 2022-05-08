import logo from './logo.svg';
import './App.css';
import React, { Component } from 'react';

//function App() {} Todo componente em react ele pode ser criado como uma class ou uma function abaixo um exemplo de class
class App extends Component {
  constructor(props) {
    super(props);

    this.state = { //isso aqui só armazena dados em tempo de execução
      showImage: false,
    };
  }

  toggle = () => {
    this.setState({
      showImage: !this.state.showImage,
    });
  } // sempre que eu quiser alterar o valor de um state eu devo fazer isso via arrow function

  render() {
    return (
      <div className="App" >
        <header className="App-header" >
          <button type="button" onClick={this.toggle}>
            {this.state.showImage ? 'Esconder' : 'Mostrar'}
          </button>
          {this.state.showImage && ( //Conditional render
            <img src={logo} className="App-logo" alt="logo" />
          )}
          <p>Edit<code> src / App.js </code> and save to reload. </p>
          <a className="App-link" href="https://reactjs.org" target="_blank" rel="noopener noreferrer" >Learn React </a>
        </header>
      </div>
    );
  }
}
export default App;