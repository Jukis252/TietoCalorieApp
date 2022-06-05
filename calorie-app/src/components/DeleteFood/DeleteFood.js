import { Button, TextField } from '@mui/material';
import './DeleteFood.css';
import { useState } from 'react';
import FoodService from '../../services/FoodService';

const foodService = new FoodService();

function DeleteFood() {
  const [foodName, setFoodName] = useState('');

  const handleNameChange = (event) => {
    setFoodName(event.target.value);
  };
  const deleteFood = () => {
    foodService
      .deleteFoodByName(foodName)
      .then((response) => {
        if (!response.ok) {
          throw Error('Could not POST the data to database, response not OK');
        }
        return response.json();
      })
      .catch();
  };
  return (
    <div className="content">
      <div className="foodName">
        <TextField
          className="FoodName"
          label="Food name"
          onChange={handleNameChange}
          value={foodName}
        />
      </div>
      <div className="postButton">
        <Button className="PostButton" variant="outlined" onClick={deleteFood}>
          Delete
        </Button>
      </div>
    </div>
  );
}

export default DeleteFood;
