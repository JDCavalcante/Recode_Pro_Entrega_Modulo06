import { createNativeStackNavigator } from "@react-navigation/native-stack";
import Welcome from "../pages/welcome";
import SignIn from "../pages/Signin";
import App from "../pages/List";
import List from "../pages/List";

const Stack = createNativeStackNavigator();

export default function Routes(){
    return(
        <Stack.Navigator>
            <Stack.Screen
            name="Welcome"
            component={Welcome}
            options={{headerShown: false}}
            />
            <Stack.Screen
            name="SignIn"
            component={SignIn}
            options={{headerShown: false}}
            />
            <Stack.Screen
            name="List"
            component={List}
            options={{headerShown: false}}
            />

        </Stack.Navigator>
    )
}