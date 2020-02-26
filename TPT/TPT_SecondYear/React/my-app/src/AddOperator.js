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
            <form
               className='bg-white-900 shadow-md rounded px-64 pt-6 pb-8 mb-10'
               onSubmit={this.handleSubmit}>
               <input
                  className='mb-4 shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline w-auto'
                  type='text'
                  id='name'
                  placeholder='Name'
                  onChange={this.handleChange}
               />
               <br />
               <input
                  className='mb-4 shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline'
                  type='text'
                  id='age'
                  placeholder='Age'
                  onChange={this.handleChange}
               />
               <br />
               <input
                  className='mb-4 shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline'
                  type='text'
                  id='belt'
                  placeholder='Belt'
                  onChange={this.handleChange}
               />
               <button className='bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded'>
                  Submit
               </button>
            </form>
         </div>
      );
   }
}
export default AddOperator;
