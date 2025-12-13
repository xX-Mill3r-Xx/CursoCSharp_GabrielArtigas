using SistemaCadastro.Enums;
using System;
using System.Windows.Forms;

namespace SistemaCadastro.Helpers
{
    public static class ComboBoxHelpers
    {
        #region Método generico para utilizar em qualquer enumerador

        public static void PopularComEnum<TEnum>(ComboBox cb) where TEnum : Enum
        {
            cb.DataSource = Enum.GetValues(typeof(TEnum));
            cb.SelectedIndex = 0;
        }

        #endregion

        public static void PopularComboBox(ComboBox cb)
        {
            cb.DataSource = Enum.GetValues(typeof(EEstadoCivil));
            cb.SelectedIndex = 0;
        }
    }
}
