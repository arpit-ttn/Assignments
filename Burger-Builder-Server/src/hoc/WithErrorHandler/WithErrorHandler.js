import React from 'react';
import Modal from '../../components/UserInterface/Modal/Modal'
import Aux from '../Auxi.js'
const withErrorhandler = (WrappedComponent,axios) =>
{
	return class extends React.Component
	{
		constructor()
		{
			super();
			this.state = {
				error: null
			}
		}
		componentDidMount()
		{
			axios.interceptors.response.use(req => {
				this.setState({error:null})
				return req;
			});

			axios.interceptors.response.use(res=>res,error => {
				this.setState({error:error})
			});

		}

		errorConfirmedhandler = () =>
		{
			this.setState({error:null})
		}

		render()
		{
			return(
			<Aux>
			<Modal show={this.state.error} clicked={this.errorConfirmedhandler}>
			{this.state.error ? this.state.error.message : null}
			</Modal>
		<WrappedComponent {...this.props}/>
		</Aux>
		)
		}
	}
	
}

export default withErrorhandler;