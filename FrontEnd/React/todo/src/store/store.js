import { configureStore } from '@reduxjs/toolkit'

import combinedReducers from './CombinedReducer';
 const store = configureStore({
    reducer:combinedReducers
 })
 export default store;
 