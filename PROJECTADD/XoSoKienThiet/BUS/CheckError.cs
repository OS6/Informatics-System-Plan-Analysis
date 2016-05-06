using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XoSoKienThiet.BUS
{
    public class CheckError
    {
        private string _sErrorAvalable; //  thông tin lỗi chưa nhập

        private string _sErrorCharacter;// thông tin lỗi ký tự

        private string _sErrorNumber; // thông tin lỗi nhập số

        private bool _isError; // chỉ cần 1 thuộc tính lỗi, thì sẽ gán bằng true, và không cho thực hiện các thao tác trên lớp DAO

        public CheckError()
        {
            _isError = false;
            _sErrorAvalable = "";
            _sErrorCharacter = "";
            _sErrorNumber = "";
        }
        public bool IsError()
        {
            return _isError;
        }

        public string GetError()
        {
            if (_sErrorAvalable != "")
            {
                this._sErrorAvalable = "Bạn chưa nhập: " + this._sErrorAvalable.Remove(this._sErrorAvalable.Length - 2) + "\n";
            }
            if (_sErrorCharacter != "")
            {
                this._sErrorCharacter = this._sErrorCharacter.Remove(this._sErrorCharacter.Length - 2) + " không chứa số hay ký tự đặc biệt\n";
            }
            if (_sErrorNumber != "")
            {
                this._sErrorNumber = this._sErrorNumber.Remove(this._sErrorNumber.Length - 2) + " phải là số nguyên\n";
            }
            return this._sErrorAvalable + this._sErrorCharacter + this._sErrorNumber;
        }
        public void CheckErrorAvailable(string subject) // subject: chủ ngữ của câu
        {
            _isError = true;
            this._sErrorAvalable += (subject + ", ");
        }

        public void CheckErrorCharacter(string subject)
        {
            _isError = true;
            this._sErrorCharacter += (subject + ", ");
        }
        public void CheckErrorNumber(string subject)
        {
            _isError = true;
             this._sErrorNumber += (subject + ", ");
        }
    };
}
