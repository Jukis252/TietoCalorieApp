/* eslint-disable react/prop-types */
import { InputLabel, TextField } from '@mui/material';

function FindFood(props) {
  const {
    name,
    setName,
    placeholder,
    label,
    fullWidth,
  } = props;

  const handleChange = (event) => {
    setName(event.target.value);
  };

  return (
    <div className="textfield">
      <div className="labelText">
        <InputLabel>{label}</InputLabel>
      </div>
      <TextField
        value={name}
        onChange={handleChange}
        fullWidth={fullWidth}
        placeholder={placeholder || ''}
      />
    </div>
  );
}

export default FindFood;
