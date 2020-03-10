import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import Navbar from './components/Navbar';
import { HashRouter, Route } from 'react-router-dom';
import Home from './components/Home';
import About from './components/About';
import Contact from './components/Contact';
import './style/tailwind.css';

class App extends Component {
  render() {
    return (
      <HashRouter>
        <div className="App">
          <Navbar></Navbar>
          <Route exact path="/" component={Home}></Route>
          <Route path="/about" component={About}></Route>
          <Route path="/contact" component={Contact}></Route>
        </div>
      </HashRouter>
    );
  }
}
ReactDOM.render(<App />, document.getElementById('index'));

export default App;

const wrapper = document.getElementById('index');
wrapper ? ReactDOM.render(<App />, wrapper) : false;
