import React from 'react';
//import {Route} from 'react-router-dom'
import styles from './NavigationItems.module.css';
import NavigationItem from './NavigationItem/NavigationItem';
//import Auth from '../../../containers/Authentication/Auth';

const navigationItems = (props) => (
    <ul className={styles.NavigationItems}>
        <NavigationItem link="/" exact >Burger Builder</NavigationItem>
        { props.isAuthenticated ? <NavigationItem link="/orders">Orders</NavigationItem> :null}
        { !props.isAuthenticated
         ? <NavigationItem link="/auth">Authentication</NavigationItem>
         : <NavigationItem link="/logout">Logout</NavigationItem> }
    </ul>
);

export default navigationItems;