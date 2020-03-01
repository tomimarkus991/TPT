import React, { Component } from "react";

class AddTodo extends Component {
   state = {
      component: ""
   };
   onChange = e => {
      this.setState({
         content: e.target.value
      });
   };
   onSubmit = e => {
      e.preventDefault();
      this.props.addTodo(this.state);
      this.setState({
         content: ""
      });
   };
   render() {
      return (
         <div>
            <form onSubmit={this.onSubmit}>
               <label className='text-base text-gray-800 leading-normal'>
                  Add Todo:
               </label>
               <input
                  className='bg-gray-200 hover:bg-white hover:border-gray-300 focus:outline-none focus:bg-white focus:shadow-outline focus:border-gray-300 px-2 py-2'
                  placeholder='Enter Todo'
                  type='text'
                  onChange={this.onChange}
                  value={this.state.content}></input>
            </form>
         </div>
      );
   }
}

export default AddTodo;
