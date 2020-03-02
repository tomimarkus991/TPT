import React from "react";

const Rainbow = (WrappedComponent) => {
   const colors = ["blue", "red", "green", "yellow", "orange", "pink"];
   const randomColor = colors[Math.floor(Math.random() * colors.length)];
   const className = "text-"+ randomColor +"-500";

   return (props) => {
      return (
         <div className={className}>
            <WrappedComponent {...props} />
         </div>
      );
   };
};

export default Rainbow;
