import React from "react";

const Todos = ({ todos, deleteTodo }) => {
   const todoList = todos.length ? (
      todos.map(todo => {
         return (
            <div className='text-base text-gray-600 leading-normal'>
               <span
                  onClick={() => {
                     deleteTodo(todo.id);
                  }}>
                  {todo.content}
               </span>
            </div>
         );
      })
   ) : (
      <p>You have no todos left</p>
   );
   return <div className='todos collection'>{todoList}</div>;
};

export default Todos;
