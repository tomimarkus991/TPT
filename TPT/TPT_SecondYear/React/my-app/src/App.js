import React, { Component } from "react";
import Operators from "./Operators";
import AddOperator from "./AddOperator";

class App extends Component {
   state = {
      operators: [
         { name: "Doc", age: 42, belt: "black", id: "1" },
         { name: "Cav", age: 21, belt: "black", id: "2" },
         { name: "Valkyre", age: 31, belt: "black", id: "3" }
      ]
   };
   addOperator = operator => {
      operator.id = Math.random();
      let operators = [...this.state.operators, operator];
      this.setState({
         operators: operators
      });
   };
   render() {
      return (
         <div className='App'>
            <h1 className='block text-gray-700 text-lg font-bold mb-10 text-6xl'>
               React app
            </h1>
            <p className='block text-gray-700 text-lg font-bold mb-10'>
               Tere tulemasst
            </p>
            <Operators operators={this.state.operators} />
            <AddOperator addOperator={this.addOperator} />
         </div>
      );
   }
}

export default App;
