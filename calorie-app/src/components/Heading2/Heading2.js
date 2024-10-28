// eslint-disable-next-line import/no-extraneous-dependencies
import PropTypes from 'prop-types';
import './Heading2.css';

function Heading2(props) {
  const { children } = props;
  return <h2 className="heading">{children}</h2>;
}

Heading2.propTypes = {
  children: PropTypes.node.isRequired,
};
export default Heading2;
