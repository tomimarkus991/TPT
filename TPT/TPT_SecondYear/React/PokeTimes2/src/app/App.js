import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import Navbar from './components/Navbar';
import { BrowserRouter, Route, Switch } from 'react-router-dom';
import About from './components/About';
import Home from './components/Home';
import Contact from './components/Contact';
import Post from './components/Post';
import './style/tailwind.css';

class App extends Component {
  render() {
    return (
      <BrowserRouter>
        <div className="App">
          <Navbar></Navbar>
          <Switch>
            <Route exact path="/" component={Home}></Route>
            <Route path="/about" component={About}></Route>
            <Route path="/contact" component={Contact}></Route>
            <Route path="/:id" component={Post}></Route>
          </Switch>
        </div>
      </BrowserRouter>
    );
  }
}
// ReactDOM.render(<App />, document.getElementById('index'));

export default App;

// const wrapper = document.getElementById('index');
// wrapper ? ReactDOM.render(<App />, wrapper) : false;
