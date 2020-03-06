import React, { Component } from "react";
import Todos from "./Todos";
import AddTodo from "./AddTodo";

class App extends Component {
  state = {
    todos: [
      { id: 1, content: "Käi koearaga õues" },
      { id: 6, content: "Pese pesu" }
    ]
  };
  deleteTodo = id => {
    const todos = this.state.todos.filter(todo => {
      return todo.id !== id;
    });
    this.setState({
      todos
    });
  };
  addTodo = todo => {
    todo.id = Math.random();
    let todos = [...this.state.todos, todo];
    this.setState({
      todos
    });
  };
  render() {
    return (
      <div className='todo-app'>
        <div className='max-w-sm mx-auto flex p-6 bg-white rounded-lg shadow-xl'>
          <div className='ml-10 pt-10'>
            <h4 className='text-xl text-gray-900 leading-tight'>Todo App</h4>
            <div class='border rounded'>
              <div class='bg-white odd:bg-gray-200'>
                <Todos
                  className='block text-base text-gray-600 leading-normal border rounded'
                  deleteTodo={this.deleteTodo}
                  todos={this.state.todos}
                />
              </div>
            </div>
            <AddTodo addTodo={this.addTodo}></AddTodo>
          </div>
        </div>
      </div>
    );
  }
}

export default App;
