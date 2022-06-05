// eslin disable no-unused-vars
import { useEffect, useState } from 'react';
import Table from '@mui/material/Table';
import TableBody from '@mui/material/TableBody';
import TableCell from '@mui/material/TableCell';
import TableContainer from '@mui/material/TableContainer';
import TableHead from '@mui/material/TableHead';
import TableRow from '@mui/material/TableRow';
import Paper from '@mui/material/Paper';
import DishService from '../../services/DishService';

const dishService = new DishService();

// function createData(name, calories, fat, carbs, protein) {
//   return {
//     name, calories, fat, carbs, protein,
//   };
// }

function DisplayDishTable() {
  const [dish, setDish] = useState();

  useEffect(() => {
    dishService
      .getAll()
      .then((res) => {
        if (!res.ok) {
          throw Error('could not fetch the data for that resource');
        }
        return res.json();
      })
      .then((dataFromDB) => {
        setDish(dataFromDB);
      });
  }, []);

  return (
    <TableContainer component={Paper}>
      <Table sx={{ minWidth: 650 }} aria-label="simple table">
        <TableHead>
          <TableRow>
            <TableCell>Food (100g serving)</TableCell>
            <TableCell align="right">Calories</TableCell>
            <TableCell align="right">Fat&nbsp;(g)</TableCell>
            <TableCell align="right">Carbs&nbsp;(g)</TableCell>
            <TableCell align="right">Protein&nbsp;(g)</TableCell>
          </TableRow>
        </TableHead>
        <TableBody>
          {dish &&
            dish.map((dishes) => (
              <TableRow key={dishes.id} value={dishes.id}>
                <TableCell component="th" scope="row">
                  {dishes.name}
                </TableCell>
                <TableCell align="right">{dishes.calorieCount}</TableCell>
                <TableCell align="right">{dishes.fatsCount}</TableCell>
                <TableCell align="right">{dishes.carbsCount}</TableCell>
                <TableCell align="right">{dishes.proteinCount}</TableCell>
              </TableRow>
            ))}
        </TableBody>
      </Table>
    </TableContainer>
  );
}

export default DisplayDishTable;
