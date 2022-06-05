/* eslint-disable react/forbid-prop-types */
import React, { createContext, useState } from 'react';
// eslint-disable-next-line import/no-extraneous-dependencies
import PropTypes from 'prop-types';

// create context
const UserContext = createContext({});
function UserContextProvider({ children }) {
  // the value that will be given to the context
  const [user, setUser] = useState(UserContext);
  const [getSingleFoodObject, setSingleFoodObject] = useState(null);
  const [getAllFoods, setAllFoods] = useState(null);
  const [fetch, setFetch] = useState(0);

  const handleFetch = () => {
    const incrementFetch = fetch + 1;
    setFetch(incrementFetch);
  };
  // SHOULD WE SPLIT CONTEXT TO SEPARATE ONES?
  return (
    // the Provider gives access to the context to its children
    // eslint-disable-next-line react/jsx-no-constructed-context-values
    <UserContext.Provider value={{
      user,
      setUser,
      getSingleFoodObject,
      setSingleFoodObject,
      getAllFoods,
      setAllFoods,
      handleFetch,
      fetch,
    }}
    >
      {children}
    </UserContext.Provider>
  );
}
UserContextProvider.propTypes = {
  children: PropTypes.objectOf(
    PropTypes.any,
  ).isRequired,
};

export { UserContext, UserContextProvider };
