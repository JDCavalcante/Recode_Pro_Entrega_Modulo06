import { StyleSheet, Text, View } from 'react-native'
import React from 'react'

const Comp02 = () => {
  return (
    <View>
      <Text style={styles.Texto}>comp02</Text>
    </View>
  )
}

export default Comp02

const styles = StyleSheet.create({
    Texto: {backgroundColor: 'red',
    color: 'yellow'}

})