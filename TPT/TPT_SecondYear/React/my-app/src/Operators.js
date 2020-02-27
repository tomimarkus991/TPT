import React from "react";

const Operators = ({ operators, deleteOperator }) => {
   return (
      <div className='operators-list'>
         {operators.map(operator => {
            return operator.age >= 30 ? (
               <div
                  className='operator block text-gray-700 text-sm font-bold mb-2 shadow-xs'
                  key={operator.id}>
                  <div>Name: {operator.name}</div>
                  <div>Age: {operator.age}</div>
                  <div>Belt: {operator.belt}</div>
                  <button
                     className='bg-gray-800 hover:bg-red-600 text-white font-bold py-2 px-4 rounded'
                     onClick={() => {
                        deleteOperator(operator.id);
                     }}>
                     Delete
                  </button>
               </div>
            ) : null;
         })}
      </div>
   );
};
export default Operators;

// const operatorsList = operators.map(operator => {
//     if(operator.age >= 30)
//     {
// return (
//     <div className="operator" key={operator.id} >
//         <div>Name: {operator.name}</div>
//         <div>Age: {operator.age}</div>
//         <div>Belt: {operator.belt}</div>
//     </div>
// )
//     }
//     else
//     {
//         return null;
//     }

// })
