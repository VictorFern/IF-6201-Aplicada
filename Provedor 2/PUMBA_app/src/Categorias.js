import React from 'react';
import { useHistory } from "react-router-dom";
function NavigationDemo() {
  const history = useHistory();

  return (
   <div>
   <button onClick={navigateTo} type="button" />
   </div>
  );
}
export default NavigationDemo;