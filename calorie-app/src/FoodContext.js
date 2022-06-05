/* eslint-disable react/forbid-prop-types */
import React, { createContext, useState } from 'react';
// eslint-disable-next-line import/no-extraneous-dependencies
import PropTypes from 'prop-types';

// create context
const FoodContext = createContext({});
function FoodContextProvider({ children }) {
  // the value that will be given to the context
  const [food, setFood] = useState(FoodContext);
  const [getSingleFoodObject, setSingleFoodObject] = useState(null);
  const [getAllFoods, setAllFoods] = useState(null);
  const [fetch, setFetch] = useState(0);

  const handleFetch = () => {
    const incrementFetch = fetch + 1;
    setFetch(incrementFetch);
  };
  return (
    // eslint-disable-next-line react/jsx-no-constructed-context-values
    <FoodContext.Provider value={{
      user: food,
      setUser: setFood,
      getSingleFoodObject,
      setSingleFoodObject,
      getAllFoods,
      setAllFoods,
      handleFetch,
      fetch,
    }}
    >
      {children}
    </FoodContext.Provider>
  );
}
FoodContextProvider.propTypes = {
  children: PropTypes.objectOf(
    PropTypes.any,
  ).isRequired,
};

export { FoodContext, FoodContextProvider };
