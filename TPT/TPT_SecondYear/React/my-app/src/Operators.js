import React from "react";

const Operators = ({ operators }) => {
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

   return (
      <div className='operators-list'>
         {operators.map(operator => {
            return operator.age >= 30 ? (
               <div className='operator block text-gray-700 text-sm font-bold mb-2' key={operator.id}>
                  <div>Name: {operator.name}</div>
                  <div>Age: {operator.age}</div>
                  <div>Belt: {operator.belt}</div>
               </div>
            ) : null;
         })}
      </div>
   );
};
export default Operators;
