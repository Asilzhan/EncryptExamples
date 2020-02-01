import QtQuick 2.13
import QtQuick.Window 2.13
import QtQuick.Controls 2.12

Item {
    GroupBox {
        label: Label { text: qsTr("Вижинер шифрі") }
        anchors {
            top: parent.top
            left: parent.left
            right: parent.right
            topMargin: 20
            leftMargin: 20
            rightMargin: 20
        }
        Row {
            spacing: 50
            TextInput {
                id: input
            }
            TextInput {
                id: output
            }
        }
    }
}
