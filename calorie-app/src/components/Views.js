// eslint-disable-next-line import/no-extraneous-dependencies
import './Views.css';
import Box from '@mui/material/Box';
import { Divider } from '@mui/material';
import Heading2 from './Heading2/Heading2';
import DisplayFoodTable from './DisplayFoodTable/DisplayFoodTable';
import DisplayDishTable from './DisplayDishesTable/DisplayDishesTable';
import AddFood from './AddFood/AddFood';
import UpdateFood from './UpdateFood/UpdateFood';
import DeleteFood from './DeleteFood/DeleteFood';

function Views() {
  return (
    <div className="page">
      <div className="header">Calorie App</div>
      <div className="body">
        <div className="Menu">
          Menu
          <div className="MenuBody">
            <Divider />
            <Box className="BoxStyles FindFood">
              <div className="addFood">
                <Heading2>Add Food</Heading2>
                <AddFood />
              </div>
              <div className="updateFood">
                <Heading2>Update Food</Heading2>
                <UpdateFood />
              </div>
              <div className="deleteFood">
                <Heading2>Delete Food</Heading2>
                <DeleteFood />
              </div>
            </Box>
            <Divider />
          </div>
        </div>
        <div className="Display">
          Food Menu
          <div className="DisplayBody">
            <Divider />
            <Box className="BoxStyles DisplayFoodTable">
              <DisplayFoodTable />
            </Box>
            <Divider />
            Dishes Menu
            <Box className="BoxStyles DisplayDishTable">
              <DisplayDishTable />
            </Box>
          </div>
        </div>
      </div>
    </div>
  );
}

export default Views;
