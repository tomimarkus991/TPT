import React, { Component } from "react";

class AddOperator extends Component {
   state = {
      name: null,
      age: null,
      belt: null
   };
   handleChange = e => {
      this.setState({
         [e.target.id]: e.target.value
      });
   };
   handleSubmit = e => {
      e.preventDefault();
      this.props.addOperator(this.state);
   };
   render() {
      return (
         <div className='AddOp'>
            <form className='bg-pink-600' onSubmit={this.handleSubmit}>
               <label className='' htmlFor='name'>
                  Name:
               </label>
               <input type='text' id='name' onChange={this.handleChange} />
               <br />
               <label htmlFor='age'>Age:</label>
               <input type='text' id='age' onChange={this.handleChange} />
               <br />
               <label htmlFor='belt'>Belt:</label>
               <input type='text' id='belt' onChange={this.handleChange} />
               <button class='bg-blue-500 hover:bg-blue-700 rounded'>
                  Submit
               </button>
            </form>
         </div>
      );
   }
}
export default AddOperator;
